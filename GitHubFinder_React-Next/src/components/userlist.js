import React from 'react'
import User from './user'
import Loading from './newloading'

export default function UserList({ users, loading }) {
    if (loading) {
        return <Loading />
    }
    return (
        <div>
            {
                users.map(user => (
                    <User key={user.id} user={user} />
                ))
            }
        </div>
    )
}
