import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { AngularFireModule } from '@angular/fire';
import { AngularFirestoreModule } from '@angular/fire/firestore';
import { AngularFireAuthModule } from '@angular/fire/auth';


const config = {
  apiKey: "AIzaSyC57JYiLXcGIRFBDO__nq6iMFQQpakyFuQ",
  authDomain: "login-iut-7969d.firebaseapp.com",
  databaseURL: "https://login-iut-7969d.firebaseio.com",
  projectId: "login-iut-7969d",
  storageBucket: "",
  messagingSenderId: "962072782139",
  appId: "1:962072782139:web:216d279b0e494241cd431e"
}


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFireModule.initializeApp(config),
    AngularFirestoreModule,
    AngularFireAuthModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
