import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { FormsModule }          from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import {LoggingComponent} from './logging/logging.component';


import { AngularFireModule } from '@angular/fire';
import { AngularFirestoreModule } from '@angular/fire/firestore';
import { AngularFireAuthModule } from '@angular/fire/auth';
import { ApikeyComponent } from './apikey/apikey.component';
import { UploadFileComponent } from './upload-file/upload-file.component';
import { MockComponent } from './mock/mock.component';


const config = {
  apiKey: "AIzaSyC57JYiLXcGIRFBDO__nq6iMFQQpakyFuQ",
  authDomain: "login-iut-7969d.firebaseapp.com",
  databaseURL: "https://login-iut-7969d.firebaseio.com",
  projectId: "login-iut-7969d",
  storageBucket: "",
  messagingSenderId: "962072782139",
  appId: "1:962072782139:web:216d279b0e494241cd431e"
}


const appRoutes: Routes = [
  { path: '', component: WelcomeComponent },
  {
    path:'logging',component:LoggingComponent
  },
  {
    path:'apikey',component:ApikeyComponent
  },
  {
    path:'uploadfile',component:UploadFileComponent
  }

];

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    LoggingComponent,
    ApikeyComponent,
    UploadFileComponent,
    MockComponent

   // HomeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AngularFireModule.initializeApp(config),
    AngularFirestoreModule,
    AngularFireAuthModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
