import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public consultants: Consultant[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Consultant[]>(baseUrl + 'consultant').subscribe(result => {
      this.consultants = result;
    }, error => console.error(error));
  }
}

interface Consultant {
  id: number;
  firstName: string;
  lastName: string;
  startDate: Date;
}
