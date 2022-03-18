import { ForwardRefHandling } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { FormBuilder,FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent  implements OnInit{
  Adminform:FormGroup=this._fb.group({
  AdminID:['',[Validators.required,
              Validators.email]],
  Password:['',[Validators.required],]
})
constructor(private _fb:FormBuilder) {}

ngOnInit(): void {
}

submitData() {
  console.log(this.Adminform)

}


}
