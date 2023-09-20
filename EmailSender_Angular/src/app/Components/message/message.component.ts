import { Component, OnInit } from '@angular/core';
import { MessageService } from 'src/app/Services/Message.Service';

@Component({
  selector: 'app-message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.css']
})
export class MessageComponent implements OnInit {
  subject: string = '';
  content: string = '';
  
  constructor(private messageService :MessageService){}

  ngOnInit(): void {
    
  }

  sendMessage() {
    const message = {
      content: this.content,
      subject: this.subject
    }
    this.messageService.addMessage(message).subscribe(
      (response) => {
        console.log('Message added successfully', response);
        this.subject= '';
        this.content  = '';
      },
      (error) => {
        console.error('Error adding message', error);
        // Handle error, e.g., display an error message
      }
    );
  }

}
