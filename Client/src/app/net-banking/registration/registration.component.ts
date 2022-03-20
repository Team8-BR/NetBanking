import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ConfirmedValidator } from '../customvalidators/confirm-password';
import { passwordValidator } from '../customvalidators/password-validators';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(private fb : FormBuilder) { }

  registration:FormGroup= this.fb.group({
    AccountNumber : ['',[Validators.required]],
    SetLoginPassword:['',[Validators.required,
                          passwordValidator(6,10)]],
    ConfirmLoginPassword:['',[Validators.required,passwordValidator(6,10)]],
    SetTransactionPassword:['',[Validators.required,
                                passwordValidator(6,10)]],
    ConfirmTransactionPassword:['',[Validators.required,ConfirmedValidator,passwordValidator(6,10)]]                            
  })


  ngOnInit(): void {
  }
  submitData() {
    console.log(this.registration)
  }
}
