import { ResponseModel } from "./responseModel";
import { SubscriberModel } from "./subscriberModel";

export interface SubscriberResponseModel extends ResponseModel{
    data:SubscriberModel[]
}