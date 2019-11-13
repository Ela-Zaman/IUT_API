import { Component, OnInit } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/auth';
import * as firebase from 'firebase';






@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'FinalDevConsole';
  email:String;
  user:firebase.User;

  constructor(private afAuth: AngularFireAuth){
    afAuth.authState.subscribe((user) => this.user=user );
  }

  login(){
    if(this.user){
      this.email = this.user.email;
    }
    this.afAuth.auth.signInWithRedirect(new firebase.auth.GoogleAuthProvider());
  }

  logout(){
    this.afAuth.auth.signOut();
  }

  ngOnInit() {
  }

};

