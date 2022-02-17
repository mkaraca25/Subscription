import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SubscriberModelComponent } from './subscriber-model.component';

describe('SubscriberModelComponent', () => {
  let component: SubscriberModelComponent;
  let fixture: ComponentFixture<SubscriberModelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SubscriberModelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SubscriberModelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
