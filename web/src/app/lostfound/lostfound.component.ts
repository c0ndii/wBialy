import { Component } from '@angular/core';
import { PageResultModel } from '../events/model/pageResult.model';
import { DatePipe, ViewportScroller } from '@angular/common';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { lfPost } from '../events/model/lostfound.model';
import { lfService } from '../events/service/lf.service';
import {faFilter} from "@fortawesome/free-solid-svg-icons";
import {FormControl} from "@angular/forms";
import {Tags} from "../user-panel/model/user-panel.model";

@Component({
  selector: 'app-lostfound',
  templateUrl: './lostfound.component.html',
  styleUrls: ['./lostfound.component.scss']
})
export class LostfoundComponent {
  number = 1;
  events: lfPost[] = [];
  pageResult: PageResultModel={
    items: [],
    totalPages:0,
    itemFrom:0,
    itemTo:0,
    totalItemsCount:0
  };
  toppings = new FormControl();
  selectedToppings = [];
  selectedToppingsString:string[] = [];
  allTags: Tags[] = []
  constructor(private eventsService: lfService, private datePipe: DatePipe, private router: Router, public dialog: MatDialog,private scroller: ViewportScroller) {
  }
  selectedValue: string = 'zgubione';
  ngOnInit() {
    if(localStorage.getItem("Authorization")==null)
    {
      this.router.navigate(['/']);
    }
    this.getAllLFPosts();
    this.getAllTags();
  }

getDayName(dateStr: string | number | Date, locale: Intl.LocalesArgument)
{
    var date = new Date(dateStr);
    return date.toLocaleDateString(locale, { weekday: 'long' });
}



 getAllLFPosts(){
  this.eventsService.getAllLfPosts(this.number)
    .subscribe(response => {
    this.pageResult = response;
    if(this.pageResult.items.length>0)
    {
      this.events = this.pageResult.items;
    }
  });

}
  getAllTags()
  {
    this.eventsService.getAllGastroTags()
      .subscribe(response=>{
        this.allTags = response;
      })
  }
  sendFilters(){
    this.selectedToppingsString = this.selectedToppings;
    this.getAllLFPosts();
  }
  clearTags()
  {
    this.selectedToppings = [];
    this.getAllLFPosts();
  }

    protected readonly faFilter = faFilter;
}
