import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegistrationComponent } from './registration/registration.component';
import { HttpClientModule } from '@angular/common/http';
import { UsersRoutingModule } from './user-routing.module';
import { NewUserComponent } from './new-user/new-user.component';

import { SharedModule } from '../Shared/shared/shared.module';



@NgModule({
  declarations: [
    RegistrationComponent,
  
    NewUserComponent,

  ],
  imports: [
    CommonModule,
    UsersRoutingModule,
    SharedModule,
    HttpClientModule
  ],
  providers: []
})
export class UserModule { }
