import { Component, Input, OnInit } from '@angular/core';
import { IProduct } from '../../shared/models/product';
import { Basket } from '../../shared/models/basket';
import { BasketService } from '../../basket/basket.service';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.scss']
})
export class ProductItemComponent{
  @Input() product?: IProduct;
  constructor(private basketService: BasketService) { }




  addItemToBasket() {
    this.basketService.addItemToBasket(this.product);
  }
}
