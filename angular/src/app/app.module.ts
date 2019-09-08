import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule }   from '@angular/forms';
import { HomeComponent }   from './home/home.component';
import { HttpClientModule } from '@angular/common/http';
import { API_BASE_URL } from '../shared/service-proxies/service-proxies';
import { AppConsts } from '../shared/AppConst';
import { MaterialModule } from './material.module';

export function getRemoteServiceBaseUrl(): string {
    return AppConsts.remoteServiceBaseUrl;
}

@NgModule({
    imports:[ 
        BrowserModule, 
        FormsModule, 
        HttpClientModule, 
        ReactiveFormsModule, 
        MaterialModule
    ],
    declarations: [ HomeComponent ],
    bootstrap:    [ HomeComponent ],
    providers: [{ provide: API_BASE_URL, useFactory: getRemoteServiceBaseUrl } ]
})
export class AppModule { }