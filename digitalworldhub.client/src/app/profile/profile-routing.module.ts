import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ProfileComponent } from './profile.component';
import { CreateProductComponent } from './create-product/create-product.component';


const routes: Routes = [
  { path: '', component: ProfileComponent },
  { path: 'create-product', component: CreateProductComponent, data: { breadcrumb: 'Create post' } }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})
export class ProfileRoutingModule { }
