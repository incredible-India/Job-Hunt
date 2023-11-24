import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegistrationComponent } from './registration/registration.component';
import { NavbarComponent } from 'src/app/Components/navbar/navbar.component';
import { UsersRoutingModule } from './user-routing.module';
import { NewUserComponent } from './new-user/new-user.component';
import { FooterComponent } from 'src/app/Components/footer/footer.component';



@NgModule({
  declarations: [
    RegistrationComponent,
    NavbarComponent,
    NewUserComponent,
    FooterComponent
  ],
  imports: [
    CommonModule,
    UsersRoutingModule
  ]
})
export class UserModule { }
