import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import * as _ from 'lodash';
import { Response } from '@angular/http/src/static_response';
import 'rxjs/add/operator/map';

@Component({
  selector: 'app-root',
  template: `
    <ng2-smart-table [settings]="settings" [source]="data"></ng2-smart-table>
  `,
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';
  data: any;
  settings: any;
  result: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {

    this.http
      .get('http://localhost:55459/api/values')
      // component
      .subscribe(res => {
        console.log(res['columns']);
        console.log(res['data']);
        this.data = res['data'];
        let col = {
          columns: res['columns']
        };
        this.settings = col;

      });

  }
}
