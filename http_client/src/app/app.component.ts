import { Component } from '@angular/core';
import { HttpService } from './services/http.service';
import { processModel } from './model/process';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  result = 0;
  processData: processModel = new processModel();
  
  constructor(
    private _http: HttpService
  ){
    
  }

  process(): void {
    this._http.post(this.processData).subscribe(
      (response) => {
        this.result = response;
      },
      (error) => {
        console.error(error);
      }
    );
}
}
