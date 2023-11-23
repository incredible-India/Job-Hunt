import { Component } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent {
   openNav() {
    window.document.getElementById("mySidebar")?.setAttribute("style","width:250px");
    document.getElementById("main")?.setAttribute("style","margin-left: 250px");
  }
  
   closeNav() {
    window.document.getElementById("mySidebar")?.setAttribute("style","width:0");
    document.getElementById("main")?.setAttribute("style","margin-left: 0");
  }
}
