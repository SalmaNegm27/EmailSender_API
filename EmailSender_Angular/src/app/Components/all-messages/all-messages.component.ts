import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MessageService } from 'src/app/Services/Message.Service';

@Component({
  selector: 'app-all-messages',
  templateUrl: './all-messages.component.html',
  styleUrls: ['./all-messages.component.css']
})
export class AllMessagesComponent implements OnInit {
  messages :any=[];

  message :any;

  constructor(private messageService :MessageService,
    private activatedRoute: ActivatedRoute,){}
  ngOnInit(){
    this.messageService.getAllMessage().subscribe((response) => { this.messages = response });
  
  }

//   viewDeatails()
//   {
// this.messageId=this.activatedRoute.snapshot.paramMap.get('id');
// this.messageService.getMessageById(this.messageId).subscribe({
//   next:(response)=>{
//     this.message=response
//   },
//   error:(error)=>{
//     console.log(error);
//   },
//      });
//   }

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
