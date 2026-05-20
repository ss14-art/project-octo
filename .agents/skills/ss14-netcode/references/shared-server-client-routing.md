# Shared Server Client Routing

Put a type in shared when:

- it crosses the network;
- both client and server need it;
- it is predicted or replicated.

Put handling in server when:

- it validates or commits authority.

Put presentation in client when:

- it only renders state already known to the client.
