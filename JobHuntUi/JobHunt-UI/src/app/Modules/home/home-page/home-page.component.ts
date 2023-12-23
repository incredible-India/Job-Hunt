import { Component } from '@angular/core';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent {

  darkMode(){
    console.log("be happy namya");
    
    document.body.classList.toggle('dark')
    if(document.body.classList[0] == "dark")
    document.getElementsByClassName('darkmode')[0].innerHTML = "<i class=\"fa-solid fa-sun\" style=\"color:white;\"></i>"
    else
    document.getElementsByClassName('darkmode')[0].innerHTML = ` <i class="fa-solid fa-moon" ></i>`
  }


  isDropdownOpen = false;

  toggleDropdown() {
    this.isDropdownOpen = !this.isDropdownOpen;
  }

  navigateToDashboard() {
    // Add code to navigate to the dashboard
    alert('Navigating to Dashboard');
  }

  logout() {
    // Add code to perform logout
    alert('Logging out');
  }

}
