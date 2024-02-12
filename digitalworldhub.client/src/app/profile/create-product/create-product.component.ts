import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AccountService } from '../../account/account.service';
import { ProfileService } from '../profile.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.scss']
})
export class CreateProductComponent implements OnInit {
  productForm: FormGroup;
  selectedFile: File;
  response: { dbPath: '' };
  constructor(private accountService: AccountService, private fb: FormBuilder,
    private profileService: ProfileService, private router: Router) {

  }

    ngOnInit(){
      this.createProductForm();
    }


  createProductForm() {
    this.productForm = this.fb.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      price: ['', Validators.required],
      picture: ['', Validators.required],
      productType: ['', Validators.required],
      productBrand: ['', Validators.required],
      userId: ['', Validators.required]
    });
  }

  onSubmit() {
    this.profileService.createProduct(this.productForm.value).subscribe( response => {
      this.router.navigateByUrl('/shop');
    }, error => {
      console.log(error);
    });
  }

  //onFileSelected(event): void {
  //  this.selectedFile = event.target.files[0];
  //  this.productForm.get('picture').setValue(this.selectedFile);
  //}


}
