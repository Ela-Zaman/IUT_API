import { Component, OnInit,Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminComponent implements OnInit {
 @Input() counter: number = 0;
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

 iClicked(){
    this.counter++;
    this.http.get<any>("http://localhost:5000/api/values", {
    }).subscribe(response=>{
      console.log(response);
    });
  }

}
