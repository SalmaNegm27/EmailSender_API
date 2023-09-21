import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MessageService } from 'src/app/Services/Message.Service';

@Component({
  selector: 'app-messagedetail',
  templateUrl: './messagedetail.component.html',
  styleUrls: ['./messagedetail.component.css']
})
export class MessagedetailComponent implements OnInit {
messageId:any;
message:any ={};

  constructor( private messageService:MessageService,private activatedRoute:ActivatedRoute) {
  }
  ngOnInit(): void {
    this.messageId =  this.activatedRoute.snapshot.paramMap.get('id');
    this.messageService.getMessageById(this.messageId).subscribe({
       next:(response)=>{
         console.log(response)
         this.message=response
        },
      error(err) {
         console.log(err)
        },
    });
  }

}
