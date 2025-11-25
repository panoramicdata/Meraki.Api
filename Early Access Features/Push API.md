# Push API - Private Beta Summary

## Overview
Push API is a new event-driven service (in private beta) that proactively sends data/notifications to receivers as events occur, eliminating the need for continuous polling. This reduces latency, improves efficiency, and enables more responsive applications.

## Prerequisites
- Full organization permission required
- Ability to set up a webhook receiver (e.g., webhook.site)
- Ability to make configuration changes
- Ability to disconnect at least one device from the network

## Supported Topics (Private Beta)
1. **organizationDevicesAvailabilitiesChangeHistory** - Device availability change updates
2. **organizationConfigurationChanges** - Configuration change updates

View all topics at: `https://api.meraki.com/organizations/{organizationId}/api/push/topics`

## Quick Start Guide

### 1. Configure Webhook Payload Template
- Use built-in Push template: `payloadTemplateId = wpt_00008`
- Or create custom template via `createOrganizationWebhooksPayloadTemplate`

### 2. Configure Webhook Receiver
- Create org-wide webhook receiver using `createOrganizationWebhooksHttpServer`
- Must be internet-accessible from Meraki subnets
- Requires valid SSL certificate (no self-signed certificates)

### 3. Create Push Receiver Profile
```http
POST /api/v1/organizations/:organizationId/api/push/receivers/profiles
```
```json
{
  "iname": "custom_immutable_name",
  "name": "friendly name",
  "description": "short description of this receiver's purpose",
  "receiver": {
    "id": "The org-wide webhook receiver ID from step 2"
  }
}
```

### 4. Create Push Profile (Subscribe to Topic)
```http
POST /api/v1/organizations/:organizationId/api/push/profiles
```
```json
{
  "iname": "custom_immutable_name",
  "name": "friendly name",
  "description": "short description of this profile's purpose",
  "topic": {
    "id": "organizationDevicesAvailabilitiesChangeHistory"
  },
  "receiver": {
    "iname": "The iname of the receiver profile created in step 3"
  }
}
```

### 5. Trigger an Event
- Make a configuration change and/or disconnect a Meraki device to generate a push notification

## Known Issues
- **False positive status changes**: Occasional "offline" → "online" messages may appear despite device not being offline (under investigation)

## Support & Feedback
- **Email**: meraki-push-api-beta@cisco.com
- **To leave beta**: Email support (1 business day opt-out)

## Key Benefits
- ✅ Real-time event notifications
- ✅ Eliminates unnecessary polling
- ✅ Reduced latency
- ✅ Improved efficiency
- ✅ Enables automation and responsive applications

---

*This is a private beta program. Participant feedback is crucial for API development before general availability.*
