import { Component } from '@angular/core';
import {Tags} from "../../user-panel/model/user-panel.model";
import {EventPost} from "../model/event.model";
import {PageResultModel} from "../model/pageResult.model";
import {FormControl} from "@angular/forms";
import {EventsService} from "../service/events.service";
import {DatePipe, ViewportScroller} from "@angular/common";
import {Router} from "@angular/router";
import {MatDialog} from "@angular/material/dialog";
import {UserPanelService} from "../../user-panel/service/user-panel.service";
import {EventComponent} from "../event/event.component";
import { faFilter } from '@fortawesome/free-solid-svg-icons'
@Component({
  selector: 'app-liked-events',
  templateUrl: './liked-events.component.html',
  styleUrls: ['./liked-events.component.scss']
})
export class LikedEventsComponent {
  number = 1;
  allTags: Tags[] = []
  events: EventPost[] = [];
  pageResult: PageResultModel = {
    items: [],
    totalPages: 0,
    itemFrom: 0,
    itemTo: 0,
    totalItemsCount: 0
  };
  toppings = new FormControl();
  selectedToppings = [];
  sorting = new FormControl();
  selectedSort = '';
  selectedToppingsString: string[] = [];
  faFilter = faFilter;

  constructor(private eventsService: EventsService, private datePipe: DatePipe, private router: Router, public dialog: MatDialog, private scroller: ViewportScroller, private userPanelService: UserPanelService,) {
  }
  ngOnInit() {
    this.getAllPosts();
    this.getAllTags();
  }
  canGoNext: boolean = false;
  canGoPrev: boolean = false;
  classmode = localStorage.getItem('DarkMode') === 'true' ? 'dark-mode' : '';
  selected: Date | null | string = null;

  formatDate() {
    this.selected = this.datePipe.transform(this.selected, 'YYYY-MM-dd');
  }
  getAllTags() {
    this.eventsService.getAllTags()
      .subscribe(response => {
        this.allTags = response;
      })
  }

  getAllPosts() {
    this.canGoNextPage();
    this.canGoPrevPage();
    this.eventsService.getLikedPosts(this.selectedToppingsString, this.selected, this.number, this.selectedSort)
      .subscribe(response => {
        console.log(response);
        this.events = response;
        console.log(this.events);
        //this.events = this.pageResult.items;
        //console.log(this.events);
        this.changeDateFormat();
      });
  }

  sendFilters() {
    this.selectedToppingsString = this.selectedToppings;
    this.getAllPosts();
  }
  clearTags() {
    this.selectedToppings = [];
    this.selected = "";
    this.getAllPosts();
  }
  canGoNextPage(): void {
    this.eventsService.getAllPosts(this.selectedToppingsString, this.selected, (this.number) + 1, this.selectedSort)
      .subscribe(response => {
        this.canGoNext = response.items.length === 0 ? true : false;
      });
  }

  canGoPrevPage(): void {
    this.canGoPrev = this.number === 1 ? true : false;
  }

  nextPage() {
    this.number++;
    this.getAllPosts();
    this.scroller.scrollToAnchor("eventsScroll");
  }
  backPage() {
    this.number--;
    this.getAllPosts();
    this.scroller.scrollToAnchor("eventsScroll");
  }
  changeDateFormat() {
    for (let i = 0; i < this.events.length; i++) {
      this.events[i].eventDate = <string>this.datePipe.transform(this.events[i].eventDate, 'dd.MM.yyyy hh:mm');
    }
  }
  showEvent(event: EventPost) {
    const classmode = localStorage.getItem('DarkMode') === 'true' ? 'dark-mode' : '';
    this.eventsService.event = event;
    const dialogRef = this.dialog.open(EventComponent, {
      autoFocus: false,
      panelClass: classmode
    });
    //this.router.navigate(['/event']);
  }

  truncateDescription(description: string, maxLength: number): string {
    if (description.length <= maxLength) {
      return description;
    } else {
      return description.slice(0, maxLength) + '...';
    }
  }
}
