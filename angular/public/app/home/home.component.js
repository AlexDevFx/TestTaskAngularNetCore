var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import * as ApiServiceProxies from '../../shared/service-proxies/service-proxies';
let HomeComponent = class HomeComponent {
    constructor(_goodsServiceProxy, _ordersServiceProxy) {
        this._goodsServiceProxy = _goodsServiceProxy;
        this._ordersServiceProxy = _ordersServiceProxy;
        this.name = '';
    }
    ngAfterViewInit() {
        this._goodsServiceProxy.getAll()
            .subscribe((goodsData) => {
            this._goods = goodsData;
        });
    }
};
HomeComponent = __decorate([
    Component({
        selector: 'my-app',
        //templateUrl: './home.component.html',
        template: `<label>Введите имя:</label>
    <input [(ngModel)]="name" placeholder="name">
    <h1>Добро пожаловать {{name}}!</h1>`,
        providers: [ApiServiceProxies.GoodsServiceProxy, ApiServiceProxies.OrdersServiceProxy]
    }),
    __metadata("design:paramtypes", [ApiServiceProxies.GoodsServiceProxy, ApiServiceProxies.OrdersServiceProxy])
], HomeComponent);
export { HomeComponent };
//# sourceMappingURL=../../../src/src/app/home/home.component.js.map