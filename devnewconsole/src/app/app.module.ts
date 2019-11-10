import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { HabijabiComponent } from './habijabi/habijabi.component';
import { GenKeyComponent } from './gen-key/gen-key.component';
import { DevconsoleComponent } from './devconsole/devconsole.component';
import { TestComponent } from './test/test.component';


@NgModule({
  declarations: [
    AppComponent,
    HabijabiComponent,
    GenKeyComponent,
    DevconsoleComponent,
    TestComponent,
 
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
