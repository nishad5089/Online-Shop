import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.scss']
})
export class TestComponent implements OnInit {

  constructor(private http: HttpClient) {
  }
  hellow: string;
  ngOnInit() {
      this.http.get('http://localhost:5000/api/hellow', {responseType: 'text'}).subscribe((h) => {
     this.hellow  = h;
     console.log(this.hellow);
      });
  }

}
