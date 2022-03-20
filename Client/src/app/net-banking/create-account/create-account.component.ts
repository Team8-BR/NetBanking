import { Component ,OnInit} from '@angular/core';
import {  FormBuilder,FormControl,FormGroup,Validators } from '@angular/forms';
import { LengthValidator } from '../customvalidators/length-validators';
import { passwordValidator } from '../customvalidators/password-validators';

@Component(
  {
  selector: 'app-create-account',
  templateUrl: './create-account.component.html',
  styleUrls: ['./create-account.component.css']
  })
  
export class CreateAccountComponent implements OnInit {
  Accountinfo:FormGroup=this._ai.group({
    CustomerId :['',[Validators.required]],
    title : ['',[Validators.required]],
    firstName: ['',[Validators.required]],
    lastName : ['',[Validators.required]],
    middleName:[''],
    mobileno : ['',[Validators.required,
                    passwordValidator(10,12)]],
    emailId : ['',[Validators.required,
                   Validators.email]],
    aadharCardNumber :['',[Validators.required,
                            LengthValidator.Length]] ,
    dob:[''],
    residentialAddressLine1: [''],
      residentialAddressLine2: [''],
      residentialLandmark: [''],
      residentialState: ['',[Validators.required]],
      residentialCity : ['',[Validators.required]],
      residentialPincode  : ['',[Validators.required]],
      permanentAddressLine1: [''],
      permanentAddressLine2 : [''],
      permanentLandmark : [''],
      permanentState: ['',[Validators.required]],
      permanentCity : ['',[Validators.required]],
      permanentPincode : ['',[Validators.required]],
      occupationdetails :['',[Validators.required]],
      occupationType: ['',[Validators.required]],
      sourceofincome : ['',[Validators.required]],
      grossAnnualIncome :['',[Validators.required]],
      status :[''],

                          
  })
  constructor(private _ai:FormBuilder){}
  ngOnInit():void{

  }
  submitData() {
    console.log(this.Accountinfo)
  }
  
    
}
