import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.scss']
})
export class ValueComponent implements OnInit {
  values: any;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getValue();
  }

  getValue() {
    this.http.get('http://localhost:5000/api/values').subscribe((resolve) => {
      this.values = resolve;
    }, error => {
      console.log(error);
    });
  }
}
