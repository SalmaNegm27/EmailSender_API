import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MessageService } from 'src/app/Services/Message.Service';
import { SharedDataService } from 'src/app/Services/shared-data.service';

@Component({
  selector: 'app-message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.css']
})
export class MessageComponent implements OnInit {
  subject: string = '';
  content: string = '';
  
  constructor(private messageService :MessageService, private sharedDataService :SharedDataService){}

  ngOnInit(): void {
    
  }

messageForm = new FormGroup({
subject : new FormControl('',[Validators.required,Validators.maxLength(100)]),
content : new FormControl('',[Validators.required])
});

get getMessageSubject() {
  return this.messageForm.controls['subject'];
}
get getMessageContent() {
  return this.messageForm.controls['content'];
}

  sendMessage(e:any) {
    const message = {
      content: this.content,
      subject: this.subject
    }
    if(this.messageForm.status== 'VALID')
    {
      e.preventDefault();
      this.messageService.addMessage(this.messageForm.value).subscribe(
        (response) => {
          console.log('Message added successfully', response);
          this.subject= '';
          this.content= '';
  
       this.sharedDataService.notifyMessageAdded();
        },
        (error) => {
          console.error('Error adding message', error);
          // Handle error, e.g., display an error message
        }
      );
    }
    
  }

}
