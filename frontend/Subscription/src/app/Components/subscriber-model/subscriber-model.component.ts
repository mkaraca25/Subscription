import { Component, OnInit } from '@angular/core';
import { SubscriberModel } from 'src/app/models/subscriberModel';

@Component({
  selector: 'app-subscriber-model',
  templateUrl: './subscriber-model.component.html',
  styleUrls: ['./subscriber-model.component.css']
})
export class SubscriberModelComponent implements OnInit {
  subscriberModel:SubscriberModel[]=[];
  //
  constructor() { }

  ngOnInit(): void {
  }

}
