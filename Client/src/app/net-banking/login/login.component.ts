import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  choice = 0
  constructor(private router: Router) { }
  ngOnInit(): void {
  }
  saveSelection(choice: number) {
    this.choice = choice
  }

  
  login() {
    switch (this.choice) {
      case 1:
        this.router.navigateByUrl("/user");
        break;

      case 2:
        this.router.navigateByUrl("/admin");
        break;
    }
  }
}
