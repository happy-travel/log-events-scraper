## supplier-options-provider

### HappyTravel.SupplierOptionsProvider/Logger/LogEvents.json
```json
[
    {
        "id": 6001,
        "name": "SuppliersStorageRefreshed",
        "level": "Debug",
        "template": "Suppliers storage was refreshed with {Count} suppliers",
        "argumentTypes": [
            "int"
        ],
        "hasException": false
    },
    {
        "id": 6002,
        "name": "SupplierStorageUpdateFailed",
        "level": "Error",
        "template": "Supplier storage update failed with error {Error}",
        "argumentTypes": [
            "string"
        ],
        "hasException": true
    }
]

```

## open-travel-connector

### HappyTravel.OpenTravelConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {
    "id": 99001,
    "name": "PropertiesRequestFromKomoroFailed",
    "template": "Properties request from Komoro failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  }
]
```

## travelgatex-channel

### HappyTravel.TravelgateXChannel.Api/Infrastructure/Logging/LogEvents.json
```json
﻿[
  {"id": 20001, "name": "ModelBindingFailure", "level": "Error", "template": "Failed to bind model to '{Type}'", "argumentTypes": ["string"]},
  {"id": 20002, "name": "ErrorResponseReceived", "level": "Warning", "template": "API request to {Url} failed with {StatusCode}. Request '{Request}', response {Response}.", "argumentTypes": ["string","System.Net.HttpStatusCode?","string", "string"]},
  {"id": 20101, "name": "GetClientCredentialsFailure", "level": "Warning", "template": "Failed to get client credentials from the request model"},
  {"id": 20102, "name": "AvailTimeoutReached", "level": "Warning", "template": "Availability search request timeout reached {TimeoutSeconds} sec", "argumentTypes": ["int"]},
  {"id": 20103, "name": "ParseOptionsFailure", "level": "Warning", "template": "Could not parse option parameters from {Parameters}", "argumentTypes": ["System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>"]}, 
  {"id": 20201, "name": "ApiRequest", "level": "Debug", "template": "API request to {Url} completed with {StatusCode}. RequestBody: `{RequestBody}`, response body: `{ResponseBody}`", "argumentTypes": ["string", "System.Net.HttpStatusCode?", "string", "string"]},
  {"id": 20202, "name": "AvailabilityResultReturned", "level": "Information", "template": "Returned {ResultCount} availability results after {AttemptCount} attempts", "argumentTypes": ["int", "int"]},
  {"id": 20203, "name": "AvailabilityResultsError", "level": "Warning", "template": "Failed to execute availability request, error {Error}", "argumentTypes": ["string"]},
  {"id": 20210, "name": "ValuationResultReturned", "level": "Information", "template": "Valuation result returned successfully after {AttemptCount} attempts.", "argumentTypes": ["int"]},
  {"id": 20221, "name": "ClientCheckFailure", "level": "Warning", "template": "Failed validate client credentials for {ClientName}", "argumentTypes": ["string"]},
  {"id": 20222, "name": "EvaluationResult", "level": "Information", "template": "Evaluation returned `{Result}`", "argumentTypes": ["string"]},
  {"id": 20223, "name": "EvaluationFailed", "level": "Error", "template": "Evaluation failed with error `{Error}`", "argumentTypes": ["string"]},
  {"id": 20224, "name": "UnhandledException", "level": "Error", "template": "Unhandled exception"}
]
```

## hotelbook-pro-connector

### HappyTravel.HotelbookProConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {
    "id": 90001,
    "name": "SupplierSearchRequestFailed",
    "template": "Search request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 90002,
    "name": "SupplierGetResultsRequestFailed",
    "template": "Get results request for search Id `{SearchId}` failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string", "string" ]
  },
  {
    "id": 90003,
    "name": "SupplierGetRecomendedRatesRequestFailed",
    "template": "Get recomended rates request for search Id `{SearchId}` failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string", "string" ]
  },
  {
    "id": 90011,
    "name": "GetAvailabilityFromStorageFailed",
    "template": "Get availability by id `{AvailabilityId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 90012,
    "name": "GetAccommodationAvailabilityFromStorageFailed",
    "template": "Get availability by id `{AvailabilityId}` and accommodation id `{AccommodationId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "string", "string" ]
  },
  {
    "id": 90013,
    "name": "GetRoomContractSetAvailabilityFromStorageFailed",
    "template": "Get availability by id `{AvailabilityId}` and room contract set id `{RoomContractSetId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "string", "System.Guid" ]
  },
  {
    "id": 90014,
    "name": "GetRoomContractSetDataFromStorageFailed",
    "template": "Get room contract set by id `{RoomContractSetId}` and availability id `{AvailabilityId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "System.Guid", "string" ]
  },
  {
    "id": 90015,
    "name": "GetBookingFromStorageFailed",
    "template": "Get booking from storage failed",
    "level": "Warning"
  }
]
```

## netstorming-connector

### HappyTravel.NetstormingConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {"id": 3011, "name": "BookingRequestStarted", "template": "Booking request started", "level": "Information"},
  {"id": 3012, "name": "BookingRequestCompleted", "template": "Booking request completed", "level": "Information"},
  {"id": 3013, "name": "BookingRequestFailed", "template": "Booking request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3014, "name": "CancelBookingRequestStarted", "template": "Cancel booking request started", "level": "Information"},
  {"id": 3015, "name": "CancelBookingRequestCompleted", "template": "Cancel booking request completed", "level": "Information"},
  {"id": 3016, "name": "CancelBookingRequestFailed", "template": "Cancel booking request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3017, "name": "BookingStatusRequestStarted", "template": "Booking status request started", "level": "Information"},
  {"id": 3018, "name": "BookingStatusRequestCompleted", "template": "Booking status request completed", "level": "Information"},
  {"id": 3019, "name": "BookingStatusRequestFailed", "template": "Booking status request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3020, "name": "SearchRequestStarted", "template": "Search request started", "level": "Information"},
  {"id": 3021, "name": "SearchRequestCompleted", "template": "Search request completed", "level": "Information"},
  {"id": 3022, "name": "SearchRequestFailed", "template": "Search request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3023, "name": "AccommodationRequestStarted", "template": "Accommodation request started", "level": "Information"},
  {"id": 3024, "name": "AccommodationRequestCompleted", "template": "Accommodation request completed", "level": "Information"},
  {"id": 3025, "name": "AccommodationRequestFailed", "template": "Accommodation request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3026, "name": "RoomRequestStarted", "template": "Room request started", "level": "Information"},
  {"id": 3027, "name": "RoomRequestCompleted", "template": "Room request completed", "level": "Information"},
  {"id": 3028, "name": "RoomRequestFailed", "template": "Room request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3032, "name": "DeadlineRequestStarted", "template": "Deadline request started", "level": "Information"},
  {"id": 3033, "name": "DeadlineRequestCompleted", "template": "Deadline request completed", "level": "Information"},
  {"id": 3034, "name": "DeadlineRequestFailed", "template": "Deadline request failed with error `{Error}`", "level": "Warning", "argumentTypes": [ "string" ]}
]
```

## rakuten-connector

### HappyTravel.RakutenConnector.Updater/Infrastructure/Logging/LogEvents.json
```json
[
    {"id": 30201, "name": "UpdatingRawPropertyCodes", "level": "Information", "template": "Updating property codes: {PropertyCodes}", "argumentTypes": ["string[]"]},
    {"id": 30210, "name": "RawDataUpdateStarted", "level": "Information", "template": "Starting raw data update with id: {Id}", "argumentTypes": ["int"]},
    {"id": 30211, "name": "RawDataUpdateFinished", "level": "Information", "template": "Raw data update with id: {Id} finished successfully", "argumentTypes": ["int"]}
]
```

## columbus-connector

### HappyTravel.ColumbusConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {
    "id": 3011,
    "name": "BookingRequestStarted",
    "template": "Booking request started",
    "level": "Information"
  },
  {
    "id": 3012,
    "name": "BookingRequestCompleted",
    "template": "Booking request completed",
    "level": "Information"
  },
  {
    "id": 3013,
    "name": "BookingRequestFailed",
    "template": "Booking request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3014,
    "name": "CancelBookingRequestStarted",
    "template": "Cancel booking request started",
    "level": "Information"
  },
  {
    "id": 3015,
    "name": "CancelBookingRequestCompleted",
    "template": "Cancel booking request completed",
    "level": "Information"
  },
  {
    "id": 3016,
    "name": "CancelBookingRequestFailed",
    "template": "Cancel booking request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3017,
    "name": "BookingStatusRequestStarted",
    "template": "Booking status request started",
    "level": "Information"
  },
  {
    "id": 3018,
    "name": "BookingStatusRequestCompleted",
    "template": "Booking status request completed",
    "level": "Information"
  },
  {
    "id": 3019,
    "name": "BookingStatusRequestFailed",
    "template": "Booking status request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3020,
    "name": "SearchRequestStarted",
    "template": "Search request started",
    "level": "Information"
  },
  {
    "id": 3021,
    "name": "SearchRequestCompleted",
    "template": "Search request completed",
    "level": "Information"
  },
  {
    "id": 3022,
    "name": "SearchRequestFailed",
    "template": "Search request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3023,
    "name": "AccommodationRequestStarted",
    "template": "Accommodation request started",
    "level": "Information"
  },
  {
    "id": 3024,
    "name": "AccommodationRequestCompleted",
    "template": "Accommodation request completed",
    "level": "Information"
  },
  {
    "id": 3025,
    "name": "AccommodationRequestFailed",
    "template": "Accommodation request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3026,
    "name": "RoomRequestStarted",
    "template": "Room request started",
    "level": "Information"
  },
  {
    "id": 3027,
    "name": "RoomRequestCompleted",
    "template": "Room request completed",
    "level": "Information"
  },
  {
    "id": 3028,
    "name": "RoomRequestFailed",
    "template": "Room request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3032,
    "name": "DeadlineRequestStarted",
    "template": "Deadline request started",
    "level": "Information"
  },
  {
    "id": 3033,
    "name": "DeadlineRequestCompleted",
    "template": "Deadline request completed",
    "level": "Information"
  },
  {
    "id": 3034,
    "name": "DeadlineRequestFailed",
    "template": "Deadline request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80001,
    "name": "SupplierSearchRequestFailed",
    "template": "Search request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80002,
    "name": "SupplierBookingInitRequestFailed",
    "template": "Booking init request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80003,
    "name": "SupplierBookingCommitRequestFailed",
    "template": "Booking commit request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80004,
    "name": "SupplierBookingCancelRequestFailed",
    "template": "Booking cancellation request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80005,
    "name": "SupplierBookingStatusRequestFailed",
    "template": "Get booking status request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80006,
    "name": "SupplierDeadlineRequestFailed",
    "template": "Get deadline request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80007,
    "name": "SupplierSearchCompletedWithErrors",
    "template": "Search completed with errors `{Errors}`",
    "level": "Warning",
    "argumentTypes": [ "string[]" ]
  },
  {
    "id": 80008,
    "name": "GetAvailabilityFromStorageFailed",
    "template": "Get availability by id `{AvailabilityId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80009,
    "name": "GetRoomContractSetFromStorageFailed",
    "template": "Get room contract set by availabilityId `{AvailabilityId}` and room contract set id `{RoomContractSetId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "string", "System.Guid" ]
  },
  {
    "id": 80010,
    "name": "GetAccommodationAvailabilityFromStorageFailed",
    "template": "Get accommodation by availabilityId `{AvailabilityId}` and room contract set id `{RoomContractSetId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "string", "System.Guid" ]
  }
]
```

**Updated on: 3/30/2022 8:44:05 AM**
