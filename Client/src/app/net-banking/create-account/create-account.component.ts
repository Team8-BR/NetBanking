import { Component ,OnInit} from '@angular/core';
import {  FormBuilder,FormGroup,Validators } from '@angular/forms';

@Component(
  {
  selector: 'app-create-account',
  templateUrl: './create-account.component.html',
  styleUrls: ['./create-account.component.css']
  })
  
export class CreateAccountComponent implements OnInit {

  login :FormGroup=this._fb.group({    
      Title:['', [Validators.required] ],

      FirstName:['',[Validators.required]],

      MiddleName:['',[Validators.required]],

      LastName:['',[Validators.required]],

      FathersName:['',[Validators.required]],

      MobileNumber:['',[Validators.required,
      Validators.maxLength(10)]],

      EmailID:['',[Validators.required,
      Validators,]],

      AadharCardNumber:['',[Validators.required,
      Validators.maxLength(12)]],

      DateofBirth:['',[Validators.required]],

      AddressLine1:['',[Validators.required]],

      AddressLine2:['',[Validators.required]],

      Landmark:['',[Validators.required]],

      State:['',[Validators.required]],

      City:['',[Validators.required]],

      Pincode:['',[Validators.required]],

      

    });
  
  constructor(private _fb:FormBuilder){}
  ngOnInit():void{

  }
  submitData(){
    console.log(this.login)
  }
  
    
}
