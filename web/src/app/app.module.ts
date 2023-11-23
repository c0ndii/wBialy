import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import { EventsComponent } from './events/events.component';
import { EventComponent } from './events/event/event.component';
import { HomeComponent } from './home/home.component';
import { SignupFormComponent } from './signup-form/signup-form.component';
import { LoginFormComponent } from './login-form/login-form.component';
import {HttpClientModule} from "@angular/common/http";
import {RouterModule, Routes} from "@angular/router";
import {DatePipe, HashLocationStrategy, LocationStrategy} from "@angular/common";
import { UserPanelComponent } from './user-panel/user-panel.component';
import {MatDialog, MatDialogModule, MatDialogRef} from "@angular/material/dialog";
import {MatButtonModule} from "@angular/material/button";
import { AddPostFormComponent } from './user-panel/add-post-form/add-post-form.component';
import { PostsConfirmedComponent } from './user-panel/posts-confirmed/posts-confirmed.component';
import { PostsUnconfirmedComponent } from './user-panel/posts-unconfirmed/posts-unconfirmed.component';
import { FooterComponent } from './footer/footer.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import { GastroComponent } from './gastro/gastro.component';
import { EditPostFormComponent } from './user-panel/posts-unconfirmed/edit-post-form/edit-post-form.component';
import {NgxGpAutocompleteModule} from "@angular-magic/ngx-gp-autocomplete";
import {Loader} from "@googlemaps/js-api-loader";
import { AddEventPostComponent } from './user-panel/add-event-post/add-event-post.component';
import { AddLfPostComponent } from './user-panel/add-lf-post/add-lf-post.component';
import { AddGastroPostComponent } from './user-panel/add-gastro-post/add-gastro-post.component';
import { LostfoundComponent } from './lostfound/lostfound.component';
import {MatInputModule} from "@angular/material/input";
import {MatSelectModule} from "@angular/material/select";
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatCardModule} from '@angular/material/card';
import {MatNativeDateModule} from '@angular/material/core';
import {MatSnackBarModule} from "@angular/material/snack-bar";
import {CKEditorModule} from "@ckeditor/ckeditor5-angular";
import { CustomSnackbarComponent } from './custom-snackbar/custom-snackbar.component';
import {RecaptchaModule} from "ng-recaptcha";
import { AdminComponent } from './user-panel/admin/admin.component';
const appRoutes: Routes = [
  {path: '', component: EventsComponent},
  {path: 'login', component: LoginFormComponent},
  {path: 'signup', component: SignupFormComponent},
  {path: 'account',component:UserPanelComponent},
  {path: 'event',component:EventComponent},
  {path: 'gastro',component:GastroComponent},
  {path: 'l&f',component:LostfoundComponent},
];
@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    EventsComponent,
    EventComponent,
    HomeComponent,
    SignupFormComponent,
    LoginFormComponent,
    UserPanelComponent,
    AddPostFormComponent,
    PostsConfirmedComponent,
    PostsUnconfirmedComponent,
    FooterComponent,
    GastroComponent,
    EditPostFormComponent,
    AddEventPostComponent,
    AddLfPostComponent,
    AddGastroPostComponent,
    LostfoundComponent,
    CustomSnackbarComponent,
    AdminComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
    MatDialogModule,
    MatButtonModule,
    FontAwesomeModule,
    BrowserAnimationsModule,
    MatButtonToggleModule,
    NgxGpAutocompleteModule,
    MatInputModule,
    MatSelectModule,
    ReactiveFormsModule,
    MatSidenavModule,
    MatDatepickerModule,
    MatCardModule,
    MatNativeDateModule,
    MatSnackBarModule,
    CKEditorModule,
    RecaptchaModule
  ],
  providers: [DatePipe,{
    provide: Loader,
    useValue: new Loader({
      apiKey: 'AIzaSyDGzemBUP_vbFaoOS4r_SZFsPGBLjDXF_4',
      libraries: ['places']
    })
  },
    {
      provide:MatDialogRef,
      useValue:{}
    },
    {provide: LocationStrategy, useClass: HashLocationStrategy}],
  bootstrap: [AppComponent]
})
export class AppModule { }
