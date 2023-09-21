import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedDataService {

   private messageAddedSource = new Subject<void>();
  messageAdded$ = this.messageAddedSource.asObservable();

  notifyMessageAdded() {
    this.messageAddedSource.next();
  }
}
