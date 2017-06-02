S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 20358
Date: 2017-06-02 20:29:29+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 20358, uid 5000)

Register Information
r0   = 0xb72eef00, r1   = 0x80109650
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb277c13d, r5   = 0xb73a1108
r6   = 0xb7423938, r7   = 0xbe8c41a0
r8   = 0x80109650, r9   = 0xb5e71708
r10  = 0xb7402570, fp   = 0x00000000
ip   = 0x80109650, sp   = 0xbe8c4180
lr   = 0xb72eef00, pc   = 0xb277c14e
cpsr = 0x600f0030

Memory Information
MemTotal:   987012 KB
MemFree:     60948 KB
Buffers:     82792 KB
Cached:     276948 KB
VmPeak:     136100 KB
VmSize:     134796 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30336 KB
VmRSS:       29520 KB
VmData:      46712 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35860 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 20358 TID = 20358
20358 20359 20829 20830 20839 

Maps Information
af12e000 af92d000 rw-p [stack:20839]
b0e5b000 b0e6c000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0e7c000 b0e81000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1312000 b131a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b132c000 b1b2b000 rw-p [stack:20830]
b1b2b000 b1b2c000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b3c000 b1b50000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b64000 b1b65000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b75000 b1b78000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b89000 b1b8a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b9a000 b1b9c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bac000 b1bae000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bbe000 b1bce000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bde000 b1bea000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1bfc000 b23fb000 rw-p [stack:20829]
b272c000 b2733000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2746000 b274c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b275c000 b278c000 r-xp /opt/usr/apps/org.example.client/bin/client
b28d5000 b29b8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29ef000 b2a17000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a29000 b3228000 rw-p [stack:20359]
b3228000 b322a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b323a000 b3244000 r-xp /lib/libnss_files-2.20-2014.11.so
b3255000 b325e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b326f000 b3280000 r-xp /lib/libnsl-2.20-2014.11.so
b3293000 b3299000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32aa000 b32ab000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32d3000 b32da000 r-xp /usr/lib/libminizip.so.1.0.0
b32ea000 b32ef000 r-xp /usr/lib/libstorage.so.0.1
b32ff000 b335e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3374000 b3388000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3398000 b33dc000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33ec000 b33f4000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3404000 b3434000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3447000 b3500000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3514000 b3567000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3578000 b3593000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35a3000 b3664000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3677000 b3687000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3697000 b36a4000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36b5000 b36bc000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36cc000 b370d000 r-xp /usr/lib/libmdm.so.1.2.12
b371d000 b3725000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3734000 b3744000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3765000 b37c5000 r-xp /usr/lib/libasound.so.2.0.0
b37d7000 b37da000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37ea000 b37ed000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b37fd000 b3802000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3812000 b3813000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3823000 b382e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3842000 b3849000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3859000 b385f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b386f000 b3874000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3884000 b389f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38af000 b38b6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38c6000 b38c9000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38da000 b3908000 r-xp /usr/lib/libidn.so.11.5.44
b3918000 b392e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b393f000 b3949000 r-xp /usr/lib/libcares.so.2.1.0
b3959000 b3963000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3973000 b3975000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3985000 b3986000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3996000 b399a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39ab000 b39d3000 r-xp /usr/lib/libui-extension.so.0.1.0
b39e4000 b3a0d000 r-xp /usr/lib/libturbojpeg.so
b3a2d000 b3a33000 r-xp /usr/lib/libgif.so.4.1.6
b3a43000 b3a89000 r-xp /usr/lib/libcurl.so.4.3.0
b3a9a000 b3abb000 r-xp /usr/lib/libexif.so.12.3.3
b3ad6000 b3aeb000 r-xp /usr/lib/libtts.so
b3afc000 b3b04000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b14000 b3bda000 r-xp /usr/lib/libdali-core.so.0.0.0
b3bfa000 b3cf2000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d11000 b3ddf000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3df6000 b3df8000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e08000 b3e0e000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e1e000 b3e41000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e52000 b3e54000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e64000 b3e66000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e77000 b3e7c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e93000 b3e95000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ea5000 b3eac000 r-xp /usr/lib/libsensord-share.so
b3ebc000 b3ed4000 r-xp /usr/lib/libsensor.so.1.1.0
b3ee5000 b3ee8000 r-xp /usr/lib/libXv.so.1.0.0
b3ef8000 b3efd000 r-xp /usr/lib/libutilX.so.1.1.0
b3f0d000 b3f12000 r-xp /usr/lib/libappcore-common.so.1.1
b3f22000 b3f29000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f3c000 b3f40000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f51000 b402f000 r-xp /usr/lib/libCOREGL.so.4.0
b404f000 b4052000 r-xp /usr/lib/libuuid.so.1.3.0
b4062000 b4079000 r-xp /usr/lib/libblkid.so.1.1.0
b408a000 b408c000 r-xp /usr/lib/libXau.so.6.0.0
b409c000 b40e3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40f5000 b40fb000 r-xp /usr/lib/libjson-c.so.2.0.1
b410c000 b4110000 r-xp /usr/lib/libogg.so.0.7.1
b4120000 b4142000 r-xp /usr/lib/libvorbis.so.0.4.3
b4152000 b4236000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4252000 b4255000 r-xp /usr/lib/libEGL.so.1.4
b4266000 b426c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b427c000 b427e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b428e000 b429b000 r-xp /usr/lib/libGLESv2.so.2.0
b42ac000 b430e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4323000 b433b000 r-xp /usr/lib/libmount.so.1.1.0
b434d000 b4361000 r-xp /usr/lib/libxcb.so.1.1.0
b4371000 b4378000 r-xp /lib/libcrypt-2.20-2014.11.so
b43b0000 b43b2000 r-xp /usr/lib/libiri.so
b43c2000 b43cd000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43de000 b4414000 r-xp /usr/lib/libpulse.so.0.16.2
b4425000 b4468000 r-xp /usr/lib/libsndfile.so.1.0.25
b447d000 b4492000 r-xp /lib/libexpat.so.1.5.2
b44a4000 b4562000 r-xp /usr/lib/libcairo.so.2.11200.14
b4576000 b457e000 r-xp /usr/lib/libdrm.so.2.4.0
b458e000 b4591000 r-xp /usr/lib/libdri2.so.0.0.0
b45a1000 b45ef000 r-xp /usr/lib/libssl.so.1.0.0
b4604000 b4610000 r-xp /usr/lib/libeeze.so.1.13.0
b4621000 b462a000 r-xp /usr/lib/libethumb.so.1.13.0
b463a000 b463d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b464d000 b4804000 r-xp /usr/lib/libcrypto.so.1.0.0
b55ef000 b55f8000 r-xp /usr/lib/libXi.so.6.1.0
b5608000 b560a000 r-xp /usr/lib/libXgesture.so.7.0.0
b561a000 b561e000 r-xp /usr/lib/libXtst.so.6.1.0
b562e000 b5634000 r-xp /usr/lib/libXrender.so.1.3.0
b5644000 b564a000 r-xp /usr/lib/libXrandr.so.2.2.0
b565a000 b565c000 r-xp /usr/lib/libXinerama.so.1.0.0
b566d000 b5670000 r-xp /usr/lib/libXfixes.so.3.1.0
b5680000 b568b000 r-xp /usr/lib/libXext.so.6.4.0
b569b000 b569d000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ad000 b56af000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56bf000 b57a1000 r-xp /usr/lib/libX11.so.6.3.0
b57b5000 b57bc000 r-xp /usr/lib/libXcursor.so.1.0.2
b57cc000 b57e4000 r-xp /usr/lib/libudev.so.1.6.0
b57e6000 b57e9000 r-xp /lib/libattr.so.1.1.0
b57f9000 b5819000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b581a000 b581f000 r-xp /usr/lib/libffi.so.6.0.2
b5830000 b5848000 r-xp /lib/libz.so.1.2.8
b5858000 b585a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b586a000 b593f000 r-xp /usr/lib/libxml2.so.2.9.2
b5954000 b59ef000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a0b000 b5a0e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a1e000 b5a37000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a48000 b5a59000 r-xp /lib/libresolv-2.20-2014.11.so
b5a6d000 b5ae7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5afc000 b5afe000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b0e000 b5b15000 r-xp /usr/lib/libembryo.so.1.13.0
b5b25000 b5b2f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b40000 b5b58000 r-xp /usr/lib/libpng12.so.0.50.0
b5b69000 b5b8c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bad000 b5bc1000 r-xp /usr/lib/libector.so.1.13.0
b5bd2000 b5bea000 r-xp /usr/lib/liblua-5.1.so
b5bfb000 b5c52000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c66000 b5c8e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5c9f000 b5cb2000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cc3000 b5cfd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d0e000 b5d1c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d2c000 b5d34000 r-xp /usr/lib/libtbm.so.1.0.0
b5d44000 b5d51000 r-xp /usr/lib/libeio.so.1.13.0
b5d61000 b5d63000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d73000 b5d78000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d88000 b5d9f000 r-xp /usr/lib/libefreet.so.1.13.0
b5db1000 b5dd1000 r-xp /usr/lib/libeldbus.so.1.13.0
b5de1000 b5e01000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e03000 b5e09000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e19000 b5e2a000 r-xp /usr/lib/libemotion.so.1.13.0
b5e3b000 b5e42000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e52000 b5e61000 r-xp /usr/lib/libeo.so.1.13.0
b5e72000 b5e84000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e95000 b5e9a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eaa000 b5ec3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed3000 b5ef0000 r-xp /usr/lib/libeet.so.1.13.0
b5f09000 b5f51000 r-xp /usr/lib/libeina.so.1.13.0
b5f62000 b5f72000 r-xp /usr/lib/libefl.so.1.13.0
b5f83000 b6068000 r-xp /usr/lib/libicuuc.so.51.1
b6085000 b61c5000 r-xp /usr/lib/libicui18n.so.51.1
b61dc000 b6214000 r-xp /usr/lib/libecore_x.so.1.13.0
b6226000 b6229000 r-xp /lib/libcap.so.2.21
b6239000 b6262000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6273000 b627a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b628c000 b62c3000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d4000 b63bf000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63d2000 b644b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b645d000 b6462000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6472000 b647c000 r-xp /usr/lib/libvconf.so.0.2.45
b648c000 b648e000 r-xp /usr/lib/libvasum.so.0.3.1
b649e000 b64a0000 r-xp /usr/lib/libttrace.so.1.1
b64b0000 b64b3000 r-xp /usr/lib/libiniparser.so.0
b64c3000 b64e9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64f9000 b64fe000 r-xp /usr/lib/libxdgmime.so.1.1.0
b650f000 b6526000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6537000 b65a2000 r-xp /lib/libm-2.20-2014.11.so
b65b3000 b65b9000 r-xp /lib/librt-2.20-2014.11.so
b65ca000 b65d7000 r-xp /usr/lib/libunwind.so.8.0.1
b660d000 b6731000 r-xp /lib/libc-2.20-2014.11.so
b6746000 b675f000 r-xp /lib/libgcc_s-4.9.so.1
b676f000 b6851000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6862000 b688c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b689d000 b68d9000 r-xp /usr/lib/libsystemd.so.0.4.0
b68db000 b695e000 r-xp /usr/lib/libedje.so.1.13.0
b6971000 b698f000 r-xp /usr/lib/libecore.so.1.13.0
b69af000 b6b36000 r-xp /usr/lib/libevas.so.1.13.0
b6b6b000 b6b7f000 r-xp /lib/libpthread-2.20-2014.11.so
b6b93000 b6dc7000 r-xp /usr/lib/libelementary.so.1.13.0
b6df6000 b6dfa000 r-xp /usr/lib/libsmack.so.1.0.0
b6e0a000 b6e11000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e21000 b6e23000 r-xp /usr/lib/libdlog.so.0.0.0
b6e33000 b6e36000 r-xp /usr/lib/libbundle.so.0.1.22
b6e46000 b6e48000 r-xp /lib/libdl-2.20-2014.11.so
b6e59000 b6e71000 r-xp /usr/lib/libaul.so.0.1.0
b6e85000 b6e8a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e9b000 b6ea8000 r-xp /usr/lib/liblptcp.so
b6eba000 b6ebe000 r-xp /usr/lib/libsys-assert.so
b6ecf000 b6eef000 r-xp /lib/ld-2.20-2014.11.so
b6f00000 b6f05000 r-xp /usr/bin/launchpad-loader
b709b000 b7565000 rw-p [heap]
be8a4000 be8c5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20358)
Call Stack Count: 21
 0: _ZN8Hoversel16callback_clickedEPvP10_Eo_OpaqueS0_ + 0x11 (0xb277c14e) [/opt/usr/apps/org.example.client/bin/client] + 0x2014e
 1: (0xb6a157ed) [/usr/lib/libevas.so.1] + 0x667ed
 2: (0xb5e5d219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5e5bfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: evas_object_smart_callback_call + 0x38 (0xb6a16edd) [/usr/lib/libevas.so.1] + 0x67edd
 5: (0xb6932167) [/usr/lib/libedje.so.1] + 0x57167
 6: (0xb6936d87) [/usr/lib/libedje.so.1] + 0x5bd87
 7: (0xb6932b21) [/usr/lib/libedje.so.1] + 0x57b21
 8: (0xb6932ef1) [/usr/lib/libedje.so.1] + 0x57ef1
 9: (0xb6933045) [/usr/lib/libedje.so.1] + 0x58045
10: (0xb6980d11) [/usr/lib/libecore.so.1] + 0xfd11
11: (0xb697cc4b) [/usr/lib/libecore.so.1] + 0xbc4b
12: (0xb6982a5d) [/usr/lib/libecore.so.1] + 0x11a5d
13: ecore_main_loop_begin + 0x3e (0xb6982c83) [/usr/lib/libecore.so.1] + 0x11c83
14: appcore_efl_main + 0x20c (0xb6e882bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
15: ui_app_main + 0xc0 (0xb3f3e909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
16: _ZN6Window10makeWindowEiPPc + 0x11e (0xb277a397) [/opt/usr/apps/org.example.client/bin/client] + 0x1e397
17: main + 0x40 (0xb2761111) [/opt/usr/apps/org.example.client/bin/client] + 0x5111
18: (0xb6f01bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
19: __libc_start_main + 0x114 (0xb66234bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f01eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 > tmp is NULL
06-02 20:29:11.382+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.382+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.382+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.382+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.382+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.562+0900 W/CERT_SVC_VCORE(20714): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-02 20:29:11.673+0900 E/rpm-installer(20714): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-02 20:29:11.673+0900 E/rpm-installer(20714): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-02 20:29:11.723+0900 E/PKGMGR_PARSER(20714): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-02 20:29:11.743+0900 I/PRIVACY-MANAGER-CLIENT(20714): SocketClient.cpp: SocketClient(37) > Client created
06-02 20:29:11.743+0900 I/PRIVACY-MANAGER-CLIENT(20714): SocketClient.cpp: connect(62) > Client connected
06-02 20:29:11.743+0900 I/PRIVACY-MANAGER-SERVER(  916): SocketService.cpp: mainloop(230) > Got incoming connection
06-02 20:29:11.743+0900 I/PRIVACY-MANAGER-CLIENT(20714): SocketClient.cpp: disconnect(72) > Client disconnected
06-02 20:29:11.753+0900 E/PKGMGR_CERT(20714): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-02 20:29:11.753+0900 E/PKGMGR_CERT(20714): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-02 20:29:11.763+0900 E/PKGMGR_CERT(20714): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-02 20:29:11.823+0900 E/rpm-installer(20714): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-02 20:29:11.823+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.823+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.823+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.823+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.823+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/ESD     (  894): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:11.833+0900 W/AUL_AMD (  612): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-02 20:29:11.843+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-02 20:29:11.843+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-02 20:29:13.594+0900 E/PKGMGR_SERVER(20711): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20714]
06-02 20:29:13.835+0900 E/PKGMGR_SERVER(20711): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:29:13.835+0900 E/PKGMGR_SERVER(20711): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:29:14.445+0900 E/PKGMGR  (20763): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-02 20:29:14.535+0900 E/PKGMGR_SERVER(20765): pkgmgr-server.c: main(2414) > package manager server start
06-02 20:29:14.575+0900 E/PKGMGR_SERVER(20765): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-02 20:29:14.585+0900 E/PKGMGR_INFO(20765): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-02 20:29:14.595+0900 E/rpm-installer(20765): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-02 20:29:14.605+0900 E/PKGMGR_SERVER(20765): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-02 20:29:14.605+0900 E/PKGMGR  (20763): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[207630002]
06-02 20:29:14.716+0900 E/PKGMGR_INSTALLER(20768): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-02 20:29:14.716+0900 E/rpm-installer(20768): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-02 20:29:14.736+0900 E/rpm-installer(20768): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-02 20:29:14.736+0900 E/rpm-installer(20768): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-02 20:29:14.736+0900 E/rpm-installer(20768): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-02 20:29:14.736+0900 E/rpm-installer(20768): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-02 20:29:14.736+0900 E/rpm-installer(20768): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-02 20:29:14.786+0900 W/CERT_SVC_VCORE(20768): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-02 20:29:14.836+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.836+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [30]
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:14.846+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.106+0900 E/rpm-installer(20768): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-02 20:29:15.106+0900 E/rpm-installer(20768): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-02 20:29:15.106+0900 E/rpm-installer(20768): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-02 20:29:15.106+0900 E/rpm-installer(20768): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-02 20:29:15.106+0900 E/rpm-installer(20768): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-02 20:29:15.106+0900 E/rpm-installer(20768): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-02 20:29:15.116+0900 E/PKGMGR_PARSER(20768): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-02 20:29:15.116+0900 E/PKGMGR_PARSER(20768): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-02 20:29:15.146+0900 I/PRIVACY-MANAGER-CLIENT(20768): SocketClient.cpp: SocketClient(37) > Client created
06-02 20:29:15.356+0900 E/PKGMGR_PARSER(20768): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-02 20:29:15.376+0900 E/PKGMGR_CERT(20768): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-02 20:29:15.376+0900 E/PKGMGR_CERT(20768): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
06-02 20:29:15.376+0900 E/PKGMGR_CERT(20768): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
06-02 20:29:15.376+0900 E/PKGMGR_CERT(20768): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
06-02 20:29:15.376+0900 E/PKGMGR_CERT(20768): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
06-02 20:29:15.376+0900 E/PKGMGR_CERT(20768): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
06-02 20:29:15.376+0900 E/PKGMGR_CERT(20768): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
06-02 20:29:15.386+0900 E/PKGMGR_CERT(20768): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-02 20:29:15.386+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [60]
06-02 20:29:15.386+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.386+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.406+0900 E/rpm-installer(20768): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-02 20:29:15.426+0900 E/rpm-installer(20768): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-02 20:29:15.426+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-02 20:29:15.426+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [100]
06-02 20:29:15.426+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.426+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:15.436+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:16.838+0900 E/PKGMGR_SERVER(20765): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 I/Tizen::App( 1233): (78) > Installation is Completed. [Package = org.example.client]
06-02 20:29:17.318+0900 I/Tizen::App( 1233): (671) > Enter. package(org.example.client), installationResult(0)
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.318+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:29:17.328+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-02 20:29:17.328+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-02 20:29:17.328+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-02 20:29:17.328+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-02 20:29:17.348+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-02 20:29:17.348+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-02 20:29:17.348+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-02 20:29:17.348+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-02 20:29:17.348+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-02 20:29:17.358+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-02 20:29:17.358+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-02 20:29:17.358+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-02 20:29:17.358+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-02 20:29:17.378+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-02 20:29:17.378+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-02 20:29:17.388+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-02 20:29:17.398+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 20:29:17.398+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 20:29:17.408+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-02 20:29:17.408+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
06-02 20:29:17.408+0900 I/Tizen::App( 1233): (840) > Enter.
06-02 20:29:17.408+0900 I/Tizen::App( 1233): (703) > Exit.
06-02 20:29:17.408+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-02 20:29:17.408+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-02 20:29:17.418+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 20:29:17.418+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 20:29:17.418+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-02 20:29:17.418+0900 I/Tizen::App( 1233): (131) > Enter
06-02 20:29:17.428+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
06-02 20:29:17.428+0900 I/Tizen::App( 1233): (883) > Exit.
06-02 20:29:17.438+0900 E/PKGMGR_SERVER(20765): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20768]
06-02 20:29:18.840+0900 E/PKGMGR_SERVER(20765): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:29:18.840+0900 E/PKGMGR_SERVER(20765): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:29:21.522+0900 W/AUL     (20822): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:29:21.522+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:29:21.532+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:29:21.542+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:29:21.542+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:29:21.542+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 20822
06-02 20:29:21.542+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:29:21.552+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:29:21.552+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:29:21.552+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-02 20:29:21.552+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-02 20:29:21.552+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-02 20:29:21.572+0900 I/abc     (20358): abc
06-02 20:29:21.572+0900 I/CAPI_APPFW_APPLICATION(20358): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:29:21.572+0900 I/CAPI_APPFW_APPLICATION(20358): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:29:21.602+0900 E/TBM     (20358): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:29:21.652+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20358, appid: org.example.client
06-02 20:29:21.652+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:29:21.672+0900 W/AUL     (20822): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20358)
06-02 20:29:21.913+0900 I/APP_CORE(20358): appcore-efl.c: __do_app(514) > [APP 20358] Event: RESET State: CREATED
06-02 20:29:21.913+0900 I/CAPI_APPFW_APPLICATION(20358): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:29:21.933+0900 E/EFL     (20358): edje<20358> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:29:21.933+0900 E/EFL     (20358): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:29:21.943+0900 E/EFL     (20358): edje<20358> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:29:21.943+0900 E/EFL     (20358): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:29:21.943+0900 E/EFL     (20358): edje<20358> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:29:21.943+0900 E/EFL     (20358): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:29:21.953+0900 W/APP_CORE(20358): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
06-02 20:29:21.953+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:29:21.953+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:29:21.953+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:29:21.963+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:29:21.963+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:29:21.973+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:29:21.983+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:29:22.053+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:29:22.053+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:29:22.053+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:29:22.063+0900 I/APP_CORE(20358): appcore-efl.c: __do_app(514) > [APP 20358] Event: RESUME State: CREATED
06-02 20:29:22.063+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:29:22.063+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:29:22.063+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:29:22.063+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(20358) status(3)
06-02 20:29:22.063+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:29:22.063+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:29:22.063+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(20358)
06-02 20:29:22.063+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20358, appid: org.example.client, status: fg
06-02 20:29:22.073+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:29:22.073+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:29:22.073+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:29:22.083+0900 I/APP_CORE(20358): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:29:22.083+0900 I/APP_CORE(20358): appcore-efl.c: __do_app(625) > [APP 20358] Initial Launching, call the resume_cb
06-02 20:29:22.083+0900 I/CAPI_APPFW_APPLICATION(20358): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:29:22.423+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(20358) status(0)
06-02 20:29:22.713+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-02 20:29:22.713+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 20358.
06-02 20:29:22.713+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2589
06-02 20:29:23.464+0900 I/UXT     (20835): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-02 20:29:23.644+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951560801
06-02 20:29:23.694+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951560867
06-02 20:29:23.915+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951561077
06-02 20:29:23.915+0900 I/MY_LOG  (20358): Button pressed
06-02 20:29:23.985+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951561143
06-02 20:29:23.985+0900 E/VCONF   (20358): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 20:29:23.985+0900 E/VCONF   (20358): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 20:29:23.985+0900 E/VCONF   (20358): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 20:29:23.985+0900 E/VCONF   (20358): vconf.c: vconf_get_bool(2729) > vconf_get_bool(20358) : db/ise/keysound error
06-02 20:29:23.985+0900 E/VCONF   (20358): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 20:29:23.985+0900 E/VCONF   (20358): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 20:29:24.035+0900 I/MY_LOG  (20358): Button unpressed
06-02 20:29:24.966+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951562126
06-02 20:29:24.966+0900 I/MY_LOG  (20358): Button pressed
06-02 20:29:25.026+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951562191
06-02 20:29:25.026+0900 I/MY_LOG  (20358): Button unpressed
06-02 20:29:25.066+0900 D/basicui (20358): successed to load edc file
06-02 20:29:26.527+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951563686
06-02 20:29:26.527+0900 I/MY_LOG  (20358): Button pressed
06-02 20:29:26.627+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951563785
06-02 20:29:26.627+0900 I/MY_LOG  (20358): Button unpressed
06-02 20:29:26.637+0900 E/EFL     (20358): elementary<20358> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
06-02 20:29:27.058+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 20:29:27.158+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951564319
06-02 20:29:27.158+0900 I/MY_LOG  (20358): Button pressed
06-02 20:29:27.228+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951564396
06-02 20:29:27.238+0900 I/MY_LOG  (20358): Button unpressed
06-02 20:29:27.258+0900 D/basicui (20358): successed to load edc file
06-02 20:29:27.268+0900 E/EFL     (20358): elementary<20358> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x8010140f into part 'swallow_content'
06-02 20:29:28.999+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951566161
06-02 20:29:29.090+0900 E/EFL     (20358): ecore_x<20358> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951566249
06-02 20:29:29.350+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 20358 pgid = 20358
06-02 20:29:29.350+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(20358)
06-02 20:29:29.350+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:29:29.370+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:29:29.370+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:29:29.370+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:29:29.370+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:29:29.370+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:29:29.400+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-02 20:29:29.400+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-02 20:29:29.400+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-02 20:29:29.410+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 20358
06-02 20:29:29.410+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[20358] terminate event is forwarded
06-02 20:29:29.410+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-02 20:29:29.410+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 20358, ]
06-02 20:29:29.410+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-02 20:29:29.410+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-02 20:29:29.410+0900 I/Tizen::App( 1233): (512) > Not registered pid(20358)
06-02 20:29:29.410+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-02 20:29:29.410+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:29:29.410+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 20358
06-02 20:29:29.410+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 20358
06-02 20:29:29.410+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2593
06-02 20:29:29.420+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:29:29.420+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:29:29.420+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 20358.
06-02 20:29:29.450+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:29:29.450+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:29:29.450+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:29:29.450+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:29:29.480+0900 W/CRASH_MANAGER(20842): worker.c: worker_job(1199) > 1120358636c69149640296
