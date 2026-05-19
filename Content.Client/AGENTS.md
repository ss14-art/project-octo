# Content.Client Agent Rules

Use `ss14-client-server-shared`, `ss14-ui-xaml`, `ss14-ui-bui`, `ss14-ui-eui`, and `ss14-sprite-rendering`.

- Put new Shine client code under `Content.Client/_sh`.
- Client code is presentation and prediction support, not authority.
- Prefer XAML for UI layout.
- Do not trust client-only checks for gameplay permissions.
- If an upstream client file must be changed, wrap the exact diff in `shine-edit` markers.
