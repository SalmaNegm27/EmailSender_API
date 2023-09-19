import { Component, OnInit } from '@angular/core';
import { MessageService } from 'src/app/Services/Message.Service';

@Component({
  selector: 'app-message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.css']
})
export class MessageComponent implements OnInit {
  messages :any =[];
  constructor(private messageService :MessageService)
  {

  }
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  onSubmit(messageData: any) {
    this.messageService.addMessage(messageData).subscribe(
      (response) => {
        console.log('Message added successfully', response);
        // Handle success, e.g., display a success message
      },
      (error) => {
        console.error('Error adding message', error);
        // Handle error, e.g., display an error message
      }
    );
  }

}
