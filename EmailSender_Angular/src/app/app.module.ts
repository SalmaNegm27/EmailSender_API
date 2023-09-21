import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MessageComponent } from './Components/message/message.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AllMessagesComponent } from './Components/all-messages/all-messages.component';
import { MessagedetailComponent } from './Components/messagedetail/messagedetail.component';

@NgModule({
  declarations: [
    AppComponent,
    MessageComponent,
    AllMessagesComponent,
    MessagedetailComponent,
    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
