import { Component, OnInit, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-habijabi',
  templateUrl: './habijabi.component.html',
  styleUrls: ['./habijabi.component.scss']
})
export class HabijabiComponent implements OnInit {
  @Input() counter: number = 0;

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  iClicked(){
    this.counter++;
    this.http.get<any>("http://localhost:60511/api/values").subscribe(response=>{
      console.log(response);
    });
  }
}