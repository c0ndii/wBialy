import { Component } from '@angular/core';
import {EventPost} from "../event.model";

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.scss']
})
export class EventComponent {
  event: EventPost = new EventPost(1,'tytul','opis','https://static.android.com.pl/uploads/2022/11/Shrek-animacja-bajka.jpg',new Date(),'Bialy',1,true,'link',new Date(),['bialy','test'])
}
