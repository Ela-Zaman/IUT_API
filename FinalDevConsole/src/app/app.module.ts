import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { HomeComponent } from './home/home.component';
import { AdminComponent } from './admin/admin.component';   
import { FormsModule }          from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';


const appRoutes: Routes = [
  { path: 'welcome', component: WelcomeComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'home', component: HomeComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    HomeComponent,
    AdminComponent],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
