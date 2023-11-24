import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegistrationComponent } from './registration/registration.component';
import { NewUserComponent } from './new-user/new-user.component';

const routes: Routes = [
  {path: '',   component: RegistrationComponent},
  {path:"newuser",component:NewUserComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UsersRoutingModule  { }
