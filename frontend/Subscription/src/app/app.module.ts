import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SubscriberModelComponent } from './Components/subscriber-model/subscriber-model.component';
import { IndexCalculationModelComponent } from './Components/index-calculation-model/index-calculation-model.component';
import { NaviComponent } from './Components/navi/navi.component';

@NgModule({
  declarations: [
    AppComponent,
    SubscriberModelComponent,
    IndexCalculationModelComponent,
    NaviComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
