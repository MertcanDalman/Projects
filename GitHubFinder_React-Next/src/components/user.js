import React from 'react'

export default function User({ user }) {
    const { avatar_url, login, html_url } = user;
    return (
        <div>
            <div className="card mb-3">
                <div className="row g-0">
                    <div className="col-md-3">
                        <img src={avatar_url} alt={avatar_url} className="img-fluid rounded-start avatar" />
                    </div>
                    <div className="col-md-9">
                        <div className="card-body">
                            <h3 className='card-title'>{login}</h3>
                            <a href={html_url} target='_blank' className='btn btn-primary'>Github Profile</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}
