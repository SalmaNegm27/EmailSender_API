import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class MessageService {
apiUrl = "https://localhost:7130/api/Message";

  constructor(private http :HttpClient) { }

  addMessage(message:any){
    return this.http.post(this.apiUrl,message);
  }

  getAllMessage()
  {
    return this.http.get(this.apiUrl);
  }

  getMessageById(id:any)
  {
    return this.http.get(`${this.apiUrl}/${id}`);
  }

  deleteMessage(id: any) {
    return this.http.delete(`${this.apiUrl}/${id}`);
  } 
}
