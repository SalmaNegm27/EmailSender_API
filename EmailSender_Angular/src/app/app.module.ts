import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MessageComponent } from './Components/message/message.component';
import { FormsModule } from '@angular/forms';
import { AllMessagesComponent } from './Components/all-messages/all-messages.component';

@NgModule({
  declarations: [
    AppComponent,
    MessageComponent,
    AllMessagesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
