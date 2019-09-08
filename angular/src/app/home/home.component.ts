import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import * as ApiServiceProxies from '../../shared/service-proxies/service-proxies';

class UserBasket{
    isBookDelivery: boolean;
    diliveryAddress: string;
    goodToBuy: ApiServiceProxies.GoodDto[];
}

@Component({
    selector: 'my-app',
    templateUrl: './home.component.html',
    providers: [ApiServiceProxies.GoodsServiceProxy, ApiServiceProxies.OrdersServiceProxy]
})
export class HomeComponent {
    name = '';
    currentGood: ApiServiceProxies.GoodDto = new ApiServiceProxies.GoodDto();
    userBasket: UserBasket = new UserBasket();
    goods: ApiServiceProxies.GoodDto[];
    myForm : FormGroup;
    responseResult;

    constructor(private _goodsServiceProxy: ApiServiceProxies.GoodsServiceProxy, private _ordersServiceProxy: ApiServiceProxies.OrdersServiceProxy) {
        this.myForm = new FormGroup({
            "goodsCount": new FormControl("1", [
                                Validators.required, 
                                Validators.min(1),
                                Validators.max(100)
                            ])
        });
    }

    ngAfterViewInit() {
        this.getGoodsList();
    }

    private getGoodsList() {
        this._goodsServiceProxy.getAll()
            .subscribe(response => {
                this.goods = response;
            });
    }

    addGood(){
        if(this.userBasket.goodToBuy === undefined)
            this.userBasket.goodToBuy = [];
        this.userBasket.goodToBuy.push(this.currentGood);
    }

    sendBuyOrder(){
        const order = new ApiServiceProxies.OrderDto();
        order.shouldBeDelivered = this.userBasket.isBookDelivery;
        order.title = "Order";
        
        for(const g of this.userBasket.goodToBuy){
            order.goods.push(g);
        }

        this._ordersServiceProxy.create(order)
            .subscribe(response => {
                this.responseResult = response;
            });
    }

    goodsIsBooked() {
        return Array.isArray(this.userBasket.goodToBuy) && this.userBasket.goodToBuy.length
    }
}