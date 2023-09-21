import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MessageService } from 'src/app/Services/Message.Service';
import { SharedDataService } from 'src/app/Services/shared-data.service';

@Component({
  selector: 'app-all-messages',
  templateUrl: './all-messages.component.html',
  styleUrls: ['./all-messages.component.css']
})
export class AllMessagesComponent implements OnInit {
  messages :any=[];

  message :any;

  constructor(private messageService :MessageService,
    private activatedRoute: ActivatedRoute,private sharedDataService:SharedDataService, private router : Router ,){}
  ngOnInit(){

    this.messageService.getAllMessage().subscribe((response) => { this.messages = response });

    this.sharedDataService.messageAdded$.subscribe(() => {
      this.messageService.getAllMessage().subscribe((response) => { this.messages = response })
    });
  
  }


deleteMessage(messageId: any) {
  this.messageService.deleteMessage(messageId).subscribe(() => {
    // After successful deletion, refresh the list of messages from the server
    this.messageService.getAllMessage().subscribe((response) => {
      console.log(response)
      this.messages = response;
    });
  }
  );
}

}
