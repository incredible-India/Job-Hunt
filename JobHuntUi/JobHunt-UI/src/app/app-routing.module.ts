import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './Components/about/about.component';

const routes: Routes = [
  {path: '',    loadChildren: () => import('./Modules/user/user.module').then(m => m.UserModule)},
  {path:"home",loadChildren:()=>import('./Modules/home/home.module').then(m=>m.HomeModule)},
  {path:"user",loadChildren:()=>import('./Modules/user/user.module').then(m=>m.UserModule)},
  {path: 'about', component:AboutComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
