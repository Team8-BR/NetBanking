import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {


  getAccountDetail(id : number){
  
    this.route.navigateByUrl(`/admin/reqaccount/${id}`)
}
  constructor( private route : Router) { }
  @Input() custID? : number
  ngOnInit(): void {
  }

}
 