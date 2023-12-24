import { Component,OnInit } from '@angular/core';
import Typed from 'typed.js';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit{
  ngOnInit(): void {
    var typed = new Typed('.element', {
      strings: ["Are you looking for a job", "You came at right place"],
      typeSpeed: 50,
      loop:true

    });


  }}
