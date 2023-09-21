import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MessageService } from 'src/app/Services/Message.Service';
import { EmailService } from 'src/app/Services/email.service';

@Component({
  selector: 'app-messagedetail',
  templateUrl: './messagedetail.component.html',
  styleUrls: ['./messagedetail.component.css']
})
export class MessagedetailComponent implements OnInit {
messageId:any;
emailId:any;
emailAddresses : string ='';
message:any ={};

  constructor( private messageService:MessageService,private activatedRoute:ActivatedRoute,private emailService :EmailService) {
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

  sendEmails(e:any)
  {
    const emailAddressesArray: string[] = this.emailAddresses.split(',');
    e.preventDefault();
    const email = {
      messageId:this.messageId,
      EmailAdresses:emailAddressesArray
    };
    console.log(email);
    this.emailService.sendEmail(email)
     .subscribe(
      response => {
        // Handle the success response 
        console.log('Emails sent successfully');
        this.emailAddresses ='';
      },
      error => {
        // Handle the error response 
        console.error('Failed to send emails', error);
      }
     );

  }

}
