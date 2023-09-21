import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MessageComponent } from './Components/message/message.component';
import { MessagedetailComponent } from './Components/messagedetail/messagedetail.component';

const routes: Routes = [
  {path:'',component:MessageComponent},
  {path:'messages',component:MessageComponent},
  {path:'messages/:id',component:MessagedetailComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
