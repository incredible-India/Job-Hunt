import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegistrationComponent } from './registration/registration.component';
import { NavbarComponent } from 'src/app/Components/navbar/navbar.component';
import { UsersRoutingModule } from './user-routing.module';



@NgModule({
  declarations: [
    RegistrationComponent,
    NavbarComponent
  ],
  imports: [
    CommonModule,
    UsersRoutingModule
  ]
})
export class UserModule { }
