import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { HomeComponent } from './home/home.component';
import { AdminComponent } from './admin/admin.component';   
import { FormsModule }          from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { UploadComponent } from './uploadcomponent/upload/upload.component';
import { FileSelectDirective } from 'ng2-file-upload';


const appRoutes: Routes = [
  { path: 'welcome', component: WelcomeComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'home', component: HomeComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    FileSelectDirective,
    WelcomeComponent,
    HomeComponent,
    AdminComponent,
    UploadComponent],
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
