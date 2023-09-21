import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmailService {
  apiUrl = "https://localhost:7130/api/Email";
  constructor(private http:HttpClient) { }

  sendEmail(emails:any)
  {
    return this.http.post(this.apiUrl,emails);
  }
}
