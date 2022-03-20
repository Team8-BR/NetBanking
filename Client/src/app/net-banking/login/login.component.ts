import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { passwordValidator } from '../customvalidators/password-validators';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  Logininfo:FormGroup=this._Li.group({
    userId:['',[Validators.required]],
    password:['',[Validators.required,
                   passwordValidator(6,10)]]
  })

  choice = 0
  constructor(private router: Router,
    private _Li:FormBuilder) { }
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
